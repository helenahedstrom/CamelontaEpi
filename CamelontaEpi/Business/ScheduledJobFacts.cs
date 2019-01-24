using System;
using CamelontaEpi.Models.Blocks;
using CamelontaEpi.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.PlugIn;
using EPiServer.Scheduler;
using EPiServer.ServiceLocation;
using EPiServer.Web;

namespace CamelontaEpi.Business
{
    [ScheduledPlugIn(DisplayName = "ScheduledJob Facts")]
    public class ScheduledJobFacts : ScheduledJobBase
    {
        private bool _stopSignaled;

        public ScheduledJobFacts()
        {
            IsStoppable = true;
        }

        /// <summary>
        /// Called when a user clicks on Stop for a manually started job, or when ASP.NET shuts down.
        /// </summary>
        public override void Stop()
        {
            _stopSignaled = true;
        }

        /// <summary>
        /// Called when a scheduled job executes
        /// </summary>
        /// <returns>A status message to be stored in the database log and visible from admin mode</returns>
        public override string Execute()
        {
            var repo = ServiceLocator.Current.GetInstance<IContentRepository>(); 


            var siteDefinitionRepository = ServiceLocator.Current.GetInstance<SiteDefinitionRepository>();
            var siteDefinitions = siteDefinitionRepository.List();
            foreach (var siteDefinition in siteDefinitions)
            {
                var startPage = siteDefinition.StartPage;


                var start = repo.Get<StartPage>(startPage).CreateWritableClone() as StartPage;
                var parentId = start.FactBlock;
                parentId.FactNumber += 1;
                var content = start as IContent;
                repo.Save(start, EPiServer.DataAccess.SaveAction.Publish,

                    EPiServer.Security.AccessLevel.NoAccess);

            }

            OnStatusChanged(String.Format("Starting execution of {0}", this.GetType()));


            //For long running jobs periodically check if stop is signaled and if so stop execution
            if (_stopSignaled)
            {
                return "Stop of job was called";
            }

            return "Another happy customer has been added.";
        }
    }
}

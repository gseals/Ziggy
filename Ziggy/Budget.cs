using System;

namespace Ziggy
{
    public class Budget
    {
        private int GovernmentBudget { get; set; } = 999999999;
        public bool AuthorizeLeap(Leaper theLeaper, DateTime dayInHistory)
        {
            var numberOfDaysToTravel = (dayInHistory - theLeaper.CurrentDate).Days;

            var costOfTravel = 1000 * numberOfDaysToTravel;

            return (costOfTravel < GovernmentBudget);

            // it costs $1000 to leap
        }
    }
}
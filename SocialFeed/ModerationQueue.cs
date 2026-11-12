using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFeed
{
    public class ModerationQueue
    {
        private List<IReportable> _toReview;
        private List<IReportable> ToReview { get { return _toReview; } }

        
        public ModerationQueue(List<IReportable> toReview)
        {
            _toReview = new List<IReportable>();
            _toReview = toReview;
        }

        public void ReportItem(IReportable item)
        {
            item.Report();
            if(item.ReportCount() >= 3  && !_toReview.Contains(item))
            {
                _toReview.Add(item);
            }
        }
    }
}

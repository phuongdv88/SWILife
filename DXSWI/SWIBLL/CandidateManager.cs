using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWIDAL;
using SWIBLL.Model;
using System.Data;
namespace SWIBLL
{
    public class CandidateManager
    {
        int mPageNumber = 1;
        int mPageSize = 50;
        private int mNumberCandidates;

        public int NumberOfCandidates
        {
            get { return mNumberCandidates; }
            set { mNumberCandidates = value; }
        }


        public int PageNumber {
            get { return mPageNumber; }
            set { mPageNumber = value; }
        }

        public int PageSize
        {
            get { return mPageSize; }
            set { mPageSize = value; }
        }

        public CandidateManager()
        {
            NumberOfCandidates = DataAccess.Instance.getNumberOfCandidates();
        }
        ~CandidateManager()
        {
                
        }

        public DataSet getCurrentPages()
        {
            return GetLimitedCandidates(mPageNumber, mPageSize);
        }

        public DataSet getNextPage()
        {
            ++mPageNumber;
            return getCurrentPages();
        }
        public DataSet getPreviewPage()
        {
            --mPageNumber;
            return getCurrentPages();
        }

        public int getNumberOfPages()
        {
            return (mNumberCandidates + mPageSize - 1) / mPageSize;
        }


        public DataSet  GetLimitedCandidates(int page_count, int page_size)
        {
            return DataAccess.Instance.getLimitedCandidates((page_count - 1) * page_size, page_size);
        }
    }
}

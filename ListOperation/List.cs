using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperation
{
    public class List
    {
        private readonly IDataList _dataList;

        public List(IDataList dataList)
        {
            _dataList = dataList;
        }

        public IList<string> GetSortedList()
        {
            IList<string> data = _dataList.GetData();

            return data
                .OrderBy(d => d)
                .ToList();
        }
    }
}

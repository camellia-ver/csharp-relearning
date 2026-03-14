using MemoApp.DAL;
using MemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoApp.BL
{
    internal class MemoService
    {
        private MemoRepository memoRepository = new MemoRepository();
    
        public bool InsertMemo(Memo memo)
        {
            if (memo == null && string.IsNullOrWhiteSpace(memo.Title))
            {
                return false;
            }

            return memoRepository.InsertMemo(memo);
        }
    }
}

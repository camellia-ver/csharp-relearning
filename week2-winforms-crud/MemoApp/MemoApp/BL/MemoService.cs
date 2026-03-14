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

        public async Task<bool> InsertMemo(Memo memo)
        {
            if (memo == null || string.IsNullOrWhiteSpace(memo.Title))
            {
                return false;
            }

            return await memoRepository.InsertMemo(memo);
        }

        public async Task<List<Memo>> GetAllMemos()
        {
            return await memoRepository.GetAllMemos();
        }

        public async Task<Memo> GetMemoById(int id)
        {
            return await memoRepository.GetMemoById(id);
        }

        public async Task<bool> UpdateMemo(Memo memo)
        {
            if (memo == null || string.IsNullOrWhiteSpace(memo.Title))
            {
                return false;
            }

            return await memoRepository.UpdateMemo(memo);
        }

        public async Task<bool> DeleteMemo(int id)
        {
            return await memoRepository.DeleteMemo(id);
        }
    }
}

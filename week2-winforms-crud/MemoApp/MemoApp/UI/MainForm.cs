using MemoApp.BL;
using MemoApp.Models;

namespace MemoApp
{
    public partial class MainForm : Form
    {
        private MemoService memoService = new MemoService();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            memoListView.Columns.Add("제목", 150);
            memoListView.Columns.Add("날짜", 100);

            LoadMemos();
        }

        private async void LoadMemos()
        {
            memoListView.Items.Clear();

            List<Memo> memos = await memoService.GetAllMemos();

            foreach (Memo memo in memos)
            {
                ListViewItem item = new ListViewItem(memo.Title);
                item.SubItems.Add(memo.Date.ToString("yyyy-MM-dd"));
                item.Tag = memo;
                memoListView.Items.Add(item);
            }
        }

        private async void creatBtn_Click(object sender, EventArgs e)
        {
            string title = titleText.Text;
            string contents = contentText.Text;

            Memo memo = new Memo(title, contents);

            if (await memoService.InsertMemo(memo))
                LoadMemos();
            else
                MessageBox.Show("메모 저장을 실패하였습니다.");
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (memoListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 메모를 선택해주세요.");
                return;
            }

            DialogResult result = MessageBox.Show("정말로 삭제하시겠습니까?",
                "삭제 확인", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Memo selectedMemo = (Memo)memoListView.SelectedItems[0].Tag;
                if (await memoService.DeleteMemo(selectedMemo.Id))
                {
                    LoadMemos();
                }
                else
                {
                    MessageBox.Show("삭제를 실패했습니다.");
                }
            }
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            if (memoListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("수정할 메모를 선택해주세요.");
                return;
            }

            Memo selectedMemo = (Memo)memoListView.SelectedItems[0].Tag;
            Memo updateMemo = new Memo(selectedMemo.Id, titleText.Text, contentText.Text, DateTime.Now);

            if (await memoService.UpdateMemo(updateMemo))
            {
                LoadMemos();
            }
            else
            {
                MessageBox.Show("메모 수정에 실패했습니다.");
            }
        }

        private void memoListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memoListView.SelectedItems.Count == 0)
            {
                titleText.Text = "";
                contentText.Text = "";
                return;
            }

            Memo selectedMemo = (Memo)memoListView.SelectedItems[0].Tag;
            titleText.Text = selectedMemo.Title;
            contentText.Text = selectedMemo.Contents;
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadMemos();
        }
    }
}

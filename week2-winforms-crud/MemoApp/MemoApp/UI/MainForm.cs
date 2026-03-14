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
            memoListView.Columns.Add("내용", 200);
            memoListView.Columns.Add("날짜", 100);

            LoadMemos();
        }

        private void LoadMemos()
        {
            memoListView.Items.Clear();

            List<Memo> memos = memoService.GetAllMemos();

            foreach(Memo memo in memos)
            {
                ListViewItem item = new ListViewItem(memo.Title);
                item.SubItems.Add(memo.Date.ToString("yyyy-MM-dd"));
                item.Tag = memo;
                memoListView.Items.Add(item);
            }
        }

        private void creatBtn_Click(object sender, EventArgs e)
        {
            string title = titleText.Text;
            string contents = contentText.Text;

            Memo memo = new Memo(title, contents);

            if (memoService.InsertMemo(memo))
                LoadMemos();
            else
                MessageBox.Show("메모 저장을 실패하였습니다.");
        }
    }
}

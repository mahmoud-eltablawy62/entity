using posts.models;

namespace posts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        postsContext context = new postsContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            var result = context.Posts.Select(p => new { p.title, p.description }).ToList();
            dgv.DataSource = result;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                post post = new post()
                {
                    title = txt_title.Text,
                    description = txt_desc.Text,
                };
                context.Posts.Add(post);
                context.SaveChanges();
                dgv.DataSource = context.Posts.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("somthing error");
            }
        }



       


    }
}
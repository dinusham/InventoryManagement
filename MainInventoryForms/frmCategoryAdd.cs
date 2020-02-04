using InventoryDataAccess;
using System;
using System.Windows.Forms;

namespace MainInventoryForms
{
    public partial class frmCategoryAdd : Form
    {
        private Form frmCategory;
        private int categoryId;
        private int userId;
        private CategoryDTO category;

        public frmCategoryAdd(Form frmCetegory, int userId)
        {
            this.frmCategory = frmCetegory;
            this.userId = userId;
            InitializeComponent();
        }

        public frmCategoryAdd(Form frmCetegory, int userId, int categoryId)
        {
            this.frmCategory = frmCetegory;
            this.userId = userId;
            this.categoryId = categoryId;
            InitializeComponent();
            ViewEditData();
        }

        private void ViewEditData()
        {
            category = Category.GetCategoryById(categoryId);
            if (category != null)
            {
                txtCategory.Text = category.CategoryName;
                chkActive.Checked = category.IsActive;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategory.Text))
            {
                MessageBox.Show("Values cannot be null");
                return;
            }
            int status = AddUpdateCategory();
            if (status > 0)
            {
                if (category != null && category.Id > 0)
                    MessageBox.Show("Successfully updated");
                else
                    MessageBox.Show("Successfully added");
                txtCategory.Text = "";
                chkActive.Checked = false;
            }
            else
                MessageBox.Show("Category didn't add or update");
        }

        private int AddUpdateCategory()
        {
            if (category != null && category.Id > 0)
            {
                category.Id = categoryId;
                category.CategoryName = txtCategory.Text;
                category.IsActive = chkActive.Checked;
                category.UpdatedBy = userId;
                return Category.UpdateCategory(category);
            }
            else
            {
                var category = new CategoryDTO()
                {
                    CategoryName = txtCategory.Text,
                    IsActive = chkActive.Checked,
                    CreatedBy = userId
                };
                return Category.AddCategory(category);
            }
        }

        private void frmCategoryAdd_FormClosing(object sender, EventArgs e)
        {
            var parent = (frmCategory)frmCategory;
            parent.frmCategory_Load(sender, e);
        }
    }
}

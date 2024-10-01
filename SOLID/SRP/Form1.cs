using System.Data.SqlClient;

namespace SRP
{

    /*
        Single Responsibility Principle

        Bir nesne sadece bir sorumluluğa sahip olmalı.

        Bir sınıfta değişiklik yapmak için birden fazla sebep buluyorsanız, bu ilkeyi ihlal ediyorsunuz demektir.
        

        
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);
            var productService = new ProductService();
            var rowsCount = productService.CreateNewProduct(name, price);
            string message = rowsCount > 0 ? "Başarılı" : "Bir sorun oluştu";
            MessageBox.Show(message);
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog()== DialogResult.OK)
            {
                BackColor = colorDialog.Color;
            }
        }
    }
}

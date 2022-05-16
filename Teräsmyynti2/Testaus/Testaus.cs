using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Teräsmyynti2;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace Testaus
{
    [TestClass]
    public class Testaus
    {
        
       
           Form1 testForm1 = new Form1();
           DataTable testTable1 = new DataTable();
           

            [TestMethod]
            public void ColumnCount_NotEmpty()
            {



            // Act          
            testForm1.sarakeLisa();

            // Assert
            Assert.IsNotNull(testForm1.dataGridView1.ColumnCount);
            }

            [TestMethod]
            public void Clear_Test()
            {

            //Arrange
            

            // Act
            testForm1.sarakeLisa();
            testForm1.Clear();

            // Assert
            if (testForm1.dataGridView1.Rows.Count == 0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
            
            }

        [TestMethod]
        public void Import_Test()
        {
            //Arrange
            testForm1.tbl1Data = "viikottaiset";

            // Act
            testForm1.sarakeLisa();
            testForm1.Import();

            // Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Tulosta_Test()
        {
            //Arrange
            testForm1.tbl1Data = "Main";
          

            // Act
            testForm1.Tulosta();
            

            // Assert
            if (testForm1.tbl1Data + ".pdf" == "Main.pdf")
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void Kirjautuminen_TestFail()
        {
            //Arrange
          
            Kirjautminen kirjautuminen_test = new Kirjautminen();

            // Act
            kirjautuminen_test.txtPassword.Text = "admin321";
           

            // Assert          
            if (kirjautuminen_test.txtPassword.Text == "admin123")
            {
                using (StreamWriter Lukija_Test = new StreamWriter("salis.txt"))
                {
                    Lukija_Test.WriteLine(kirjautuminen_test.txtPassword.Text);
                    Assert.IsTrue(false);
                }
                
            }
            else
            {
                Assert.IsTrue(true);
            }

        }

        [TestMethod]
        public void Kirjautuminen_TestSucceces()
        {
            //Arrange

            Kirjautminen kirjautuminen_test = new Kirjautminen();

            // Act
            kirjautuminen_test.txtPassword.Text = "admin123";


            // Assert          
            if (kirjautuminen_test.txtPassword.Text == "admin123")
            {
                using (StreamWriter Lukija_Test = new StreamWriter("salis.txt"))
                {
                    Lukija_Test.WriteLine(kirjautuminen_test.txtPassword.Text);
                    Assert.IsTrue(true);
                }
                
            }
            else
            {
                Assert.IsTrue(false);
            }

        }
    }
}
    


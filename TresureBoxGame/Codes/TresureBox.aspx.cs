using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TresureBoxGame
{
    public partial class TresureBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] box = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                box[i] = rnd.Next(-1, 11);
            }

            string[] myArr = TextBox1.Text.Split(',');
            int[] chosen = new int[10];   
            int count = 0;               

            for (int i = 0; i < 10; i++)
            {
                 // TextBox3.Text += box[i].ToString() + " ";

                for (int j = 0; j < myArr.Length; j++)
                {
                    if (box[i] == int.Parse(myArr[j]))
                    {
                        chosen[count] = box[i];  
                        count++;                
                        break;                    
                    }
                }
            }



            int total = 0;
            int Trap = 0;
            int Empty = 0;
            int max = 0;
            for (int i = 0; i < count; i++)
            {
                total += chosen[i];
                if (chosen[i] == -1)
                {
                    Trap++;
                }
                else if(chosen[i] == 0)
                {
                    Empty++;
                }
                if (max < chosen[i])
                {
                    max= chosen[i];
                }
            }
            if (Trap > 2)
            {
                loss();
            }
            else if(Trap<2 && total>30)
            {
                win();
            }
            else
            {
                loss();
            }

        }

        protected void loss()
        {
            Image1.ImageUrl = "https://cdn.pixabay.com/photo/2021/11/05/11/49/game-over-6771162_1280.jpg";
        }
        protected void win()
        {
            Image1.ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp8pLTzsqwvuUcRfEhHkEuoG7ysbtRSIyZ_w&s";
        }

       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machi_Koro_Casusopdracht
{
    // Door: Vinson
    public class RolSysteem
    {
        public int DobbelsteenWaarde1 { get; set; }
        public int DobbelsteenWaarde2 { get; set; }
        public bool TweeStenen { get; set; }
        public void RolWaarden()
        {
            Random random = new Random();
            DobbelsteenWaarde1 = random.Next(1, 7);  
            DobbelsteenWaarde2 = random.Next(1, 7);
           
        }

        public bool GetZijnDobbelsteenGelijk()
        {
            if (DobbelsteenWaarde1 == DobbelsteenWaarde2 && TweeStenen)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetDobbelWaarde()
        {
            
            if(TweeStenen)
            {
               int num = DobbelsteenWaarde1 + DobbelsteenWaarde2;
               return num;
            }
            else
            {
               return DobbelsteenWaarde1;   
            }



        }
        
            


        
    }
}

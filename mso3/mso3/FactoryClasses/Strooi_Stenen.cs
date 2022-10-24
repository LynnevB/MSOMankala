using System;
using System.Collections.Generic;
using System.Text;

namespace mso3
{
    abstract class Strooi_Stenen
    {
        // kuiltje dat wordt megegeven als current is het gekozen kuiltje dat leeg wordt gehaald
        // daar wordt dus niet een steentje in gegooid
        void strooiStenen(int stenen, Kuiltje current, Bord bord, bool thuiskuiltje)
        {
            int index = bord.kuiltjes.IndexOf(current);
            while (stenen > 0)
            {
                index++;
                if (index >= bord.kuiltjes.Count)
                    index = 0;

                current = bord.kuiltjes[index];
                if(!(current is Kuiltje_Thuis && !thuiskuiltje))
                    current.gooi_steentje();
                
                stenen--;
            }
        }
    }
}

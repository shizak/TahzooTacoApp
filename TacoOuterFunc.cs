// Shiza Khan
// Tahzoo Taco App
// Outer Func

using System;
using System.Collections;

class MainClass {
	public class Taco
        {
            public string Type { get; set; }
            public string Protein { get; set; }
            public string Topping { get; set; }
            public string Time { get; set; }
            public Taco(string type, string protein, string topping, string time) {
                Type = type;
                Protein = protein;
                Topping = topping;
                Time = time;
            }
        }

	public void CustomerOrder (ArrayList order) {
		//assume orders are already placed in order of arrival time
		//next order will not be taken until current order is finished
		//i.e. as though only one person is working in the taco truck

		/* Preethi's func calls mine
		will get ArrayList of one customer's orders
		count for # tacos in arraylist order
		call Tony's inner func for each individual taco in overall order
		time doesn't really matter anymore
		call William's func after whole order is done to let him know
		This func will be void and not actually return anything
		Input will loop again on Preethi's end and she'll call mine again
		*/

		int numTacos = 0;

		foreach (Taco t in order) { //each taco in order
			numTacos++;
			//call Tony's func, pass him individual taco order
		}

		//call William's func when whole order is done
		//pass him whatever he asks for
	}
}

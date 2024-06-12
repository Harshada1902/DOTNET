using System;
class hello{
    static void Main(string [] args){
        for(int i=5;i>=1;i--){     // i=5 for i = 4 
      for(int j=1;j<=5-i;j++){  //j = 1 ! <=0 not space  for j = 1 <= 1(5-4) that is 1 space then j = 2 ! <= 1
           Console.Write(" ");
      }
      for(int j=1;j<=i;j++){ //j = 1 <= 5 print 1 star then j = 2 <=5 print 2nd star 
           Console.Write("*" + " "); 
      }
       Console.WriteLine();
        }
    }
}
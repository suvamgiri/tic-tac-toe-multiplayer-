using System;

class Program {
  public static void Main (string[] args) {
   string f1= "1"; 
string f2= "2"; 
  string  f3= "3"; 
  string  f4= "4"; 
    string  f5= "5"; 
  string  f6= "6"; 
  string  f7= "7"; 
string f8= "8"; 
  string  f9= "9";  
    for(int i=0; i<10; i++){
  Console.WriteLine($"|{f1}| |{f2}| |{f3}|");
    Console.WriteLine("----------------------");
    Console.WriteLine($"|{f4}| |{f5}| |{f6}|");
    Console.WriteLine("----------------------");
    Console.WriteLine($"|{f7}| |{f8}| |{f9}|");
    Console.WriteLine("----------------------");
    
    Console.Write("Player 1, choose a number : ");
   int p1= Convert.ToInt32(Console.ReadLine());

 switch(p1){
 case 1:
   f1="0";
   break;
 case 2:
   f2="0";
   break;
 case 3:
   f3="0";
   break;
 case 4:
     f4="0";
   break;
 case 5:
   f5="0";
   break;
 case 6:
   f6="0";
   break;
 case 7:
 f7="0";
   break;
 case 8:
   f8="0";
   break; 
 case 9:
   f9="0";
   break;
   }  
      Console.WriteLine($"|{f1}| |{f2}| |{f3}|");
    Console.WriteLine("----------------------");
    Console.WriteLine($"|{f4}| |{f5}| |{f6}|");
    Console.WriteLine("----------------------");
    Console.WriteLine($"|{f7}| |{f8}| |{f9}|");
    Console.WriteLine("----------------------");
         Console.Write("Player 2, choose a number : ");
   int p2= Convert.ToInt32(Console.ReadLine());

      switch(p2){
        case 1:
   f1= "X";
   break;
 case 2:
   f2="X";
   break;
 case 3:
   f3="X";
   break;
 case 4:
     f4="X";
   break;
 case 5:
   f5="X";
        break; 
      case 6:
   f6="X";
   break;
      case 7:
   f7="X";
   break;
      case 8:
   f8="X";
   break;
      case 9:
     f9="X";
   break;
 
      }
      
    if(f1=="0"&&f2=="0"&&f3=="0"){
      Console.WriteLine("Player 1 wins");
      break;
    }else if(f4=="0"&&f5=="0"&&f6=="0"){
      Console.WriteLine("Player 1 wins");
      break;
    }else if(f7=="0"&&f8=="0"&&f9=="0"){
      Console.WriteLine("Player 1 wins");

      break;
      }
    else if(f1=="0"&&f4=="0"&&f7=="0"){
      Console.WriteLine("Player 1 wins");

      break;
    }
    else if(f2=="0"&&f5=="0"&&f8=="0"){
      Console.WriteLine("Player 1 wins");
      break;
    }
    else if(f3=="0"&&f6=="0"&&f9=="0"){
      Console.WriteLine("Player 1 wins");
      
    }else if(f1=="0"&&f5=="0"&&f9=="0"){
      Console.WriteLine("Player 1 wins");
      break;
    } else if(f3=="0"&&f5=="0"&&f7=="0"){
      Console.WriteLine("Player 1 wins");

      break;
    }
      else {
   
  
      }

    if(f1=="X"&&f2=="X"&&f3=="X"){
      Console.WriteLine("Player 2 wins");
      break;
    }else if(f4=="X"&&f5=="X"&&f6=="X") {
      Console.WriteLine("Player 2 wins");
      break;
    }
    else if(f7=="X"&&f8=="X"&&f9=="X"){
      Console.WriteLine("Player 2 wins");
      break;
      
    }else if(f1=="X"&&f4=="X"&&f7=="X"){
      Console.WriteLine("Player 2 wins");
      break;
    }
    else if(f2=="X"&&f5=="X"&&f8=="X"){
    Console.WriteLine("Player 2 wins");
      break;
    }else if(f3=="X"&&f6=="X"&&f9=="X"){
  Console.WriteLine("Player 2 wins");
      break;
      }
    else if(f1=="X"&&f5=="X"&&f9=="X"){
      Console.WriteLine("Player 2 wins");
      break;
    }
    else if(f3=="X"&&f5=="X"&&f7=="X"){
      Console.WriteLine("Player 2 wins");
      break;
    }
    else {
   

    }
      }
    }
}

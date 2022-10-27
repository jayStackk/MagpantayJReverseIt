// John Magpantay
// 10-20-2022  
// Revamp Reverse it!
// Trying out some Data validations so the program wouldn't crash if a user ever put Letters on a number inputs hence the Try parse.

// Peer review:                                     notes: 


 
// Reverse using While loop  
bool letsPlay = true;

while(letsPlay == true)
{
int numOne;
int localNum;
int newDigits = 0;
bool toValid;

Console.WriteLine("Please enter a number to be reversed.");
toValid = Int32.TryParse(Console.ReadLine() , out numOne);



//while(numb > 0)
for(int i = numOne; i > 0; i = i / 10){
    
    localNum = i % 10;
    newDigits = (newDigits * 10) + localNum;
    
}

Console.WriteLine("The number you chose is " + numOne);
Console.WriteLine("The number in reverse is " + newDigits + ".");

bool question = true;
while(question == true)
{
Console.WriteLine("Do you want to play again? Yes/No");
string playAgain = Console.ReadLine();

if(playAgain == "Yes")
{
    letsPlay = true;
    question = false;
}
else if(playAgain == "No")
{
    letsPlay = false;
    question = false;
    Console.WriteLine("Thank you for your time!!");
}
else
{
    Console.WriteLine("Invalid :( : Yes or No only pls");
    question = true;
}
}
}


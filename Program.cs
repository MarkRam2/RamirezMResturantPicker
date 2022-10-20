// Mark ramirez
// 10/19/2022
// Resturant picker
// you select what catagory you want and then it will random choose a resturant from one of the 10 or 30 in the array

Console.Clear();

bool playing = true;

while(playing == true)
{
playing = true;

Console.WriteLine("so you don't know where you want to go to eat huh");
Console.WriteLine("why don't you let me help you out with that");

bool yessir = true;
Console.WriteLine($"choose \"resturant\" or \"fast food\" \"date night\" \"random\" ");
string userinput = Console.ReadLine();
while(yessir == true)
{
userinput.ToLower();
if(userinput == "resturant" ){
yessir = false;
}else if(userinput == "fast food" ){
yessir = false;
}else if(userinput == "date night"){
yessir = false;
}else if(userinput == "random"){
yessir = false;
}else{
Console.WriteLine($"no \"resturant\" or \"fast food\" or \"date night\" \"random\" not this \"{userinput}\" ");
userinput = Console.ReadLine();
}
}

switch(userinput)
{
case "resturant":
Random rndNum = new Random();
int Rnum = rndNum.Next(0, 9);

Console.WriteLine("you need a resturant huh so how about this one");

string[] Res = { "Market Tavern", "Dave Wongs", "Mezzo", "WaterLoo", "Lumberjacks Restaurant", "Omelet House", "Moo Moo's Burger Barn", "Tommy's Cafe", "Mi Ranchito", "Romano's Macaroni Grill" };

Console.WriteLine(Res[Rnum]);

break;

case "fast food":
Random RndNum = new Random();
int RNum = RndNum.Next(0, 9);

Console.WriteLine("Fast Food huh not the tastest must be in a hurry");

string[] FF = {"Raising Cane's Chicken Fingers","Chick-fil-A","Sonic Drive-in","Super Burger Drive in","In-N-Out Burger","Popeyes","Angry Chickz","taco bell","Indian Delicacies","Jack in The box"};

Console.WriteLine(FF[RNum]);

break;

case "date night":
Random rNdNum = new Random();
int RnUm = rNdNum.Next(0, 9);

Console.WriteLine("OOh who's lucky lady/man this might be a great spot");

string[] DN = {"Prime Table","The Black Rabbit","Market Tavern","The Kitchen At StoneBrier","Midgleys Public House","EL Rancho Inn-Streak & Lobster House","Ave On The Mile","Cast Iorn Trading","WildFire Public House","The BoatHouse At River Isalnds"};

Console.WriteLine(DN[RnUm]);

break;

case "random":
Random rnDNum = new Random();
int RnuM = rnDNum.Next(0, 29);

Console.WriteLine("that indecisive huh well one o these might be good");

string[] Ran = {"Market Tavern","Dave Wongs","Mezzo","WaterLoo","Lumberjacks Restaurant","Omelet House","Moo Moo's Burger Barn","Tommy's Cafe","Mi Ranchito","Romano's Macaroni Grill","Raising Cane's Chicken Fingers","Chick-fil-A","Sonic Drive-in","Super Burger Drive in","In-N-Out Burger","Popeyes","Angry Chickz","taco bell","Indian Delicacies","Jack in The box","Prime Table","The Black Rabbit","Market Tavern","The Kitchen At StoneBrier","Midgleys Public House","EL Rancho Inn-Streak & Lobster House","Ave On The Mile","Cast Iorn Trading","WildFire Public House","The BoatHouse At River Isalnds"};

Console.WriteLine(Ran[RnuM]);

break;
}

bool yesSir = true;
Console.WriteLine($"want to play again");
string responce = Console.ReadLine();
while(yesSir == true)
{
responce.ToLower();
if(responce == "yes" ){
yesSir = false;
playing = true;
}else if(responce == "no" ){
yesSir = false;
playing = false;
}else{
Console.WriteLine($"so like i need a yes or no not this \"{responce}\" ");
responce = Console.ReadLine();
}
}
}

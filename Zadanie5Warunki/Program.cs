//poseł 21
//senator 30
//prezydent 35

int age;


Console.WriteLine("Wprowadź swój wiek: ");
var enteredAge = Console.ReadLine();

Int32.TryParse(enteredAge, out age);

if (age >= 21)
{
    Console.WriteLine("Możesz zostać posłem.");
}
else if (age >= 30)
{
    Console.WriteLine("Możesz zostać posłem lub senatorem.");
}
else if (age >= 35)
{
    Console.WriteLine("Możesz zostać posłem, senatorem lub prezydentem.");
}else if(age < 21)
{
    Console.WriteLine("Nie możesz objąć żadnej posady w parlamencie. Jesteś za młody. Ciesz się ;) ");
}
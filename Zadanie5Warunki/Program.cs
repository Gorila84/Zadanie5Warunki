
Console.WriteLine("Wprowadź swój wiek: ");
var enteredAge = Console.ReadLine();

Int32.TryParse(enteredAge, out int age);

if (age >= 21 && age < 30)
{
    Console.WriteLine("Możesz zostać posłem.");
}
else if (age >= 30 && age <35)
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
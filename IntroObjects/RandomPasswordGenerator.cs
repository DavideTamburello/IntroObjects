using System.Text;

namespace IntroObjects;

public class RandomPasswordGenerator
{
	private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	private const string SmallLetters =
	"abcdefghijklmnopqrstuvwxyz";
	private const string Digits = "0123456789";
	private const string SpecialChars =
	"~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";
	private const string AllChars =
	CapitalLetters + SmallLetters + Digits + SpecialChars;
	private static Random rnd = new Random();

	
	public static string GetPassword()
	{
		StringBuilder password = new StringBuilder();
		// Generate two random capital letters
		for (int i = 1; i <= 2; i++)
		{
			char capitalLetter = GenerateChar(CapitalLetters);
			InsertAtRandomPosition(password, capitalLetter);
		}
		// Generate two random small letters
		for (int i = 1; i <= 2; i++)
		{
			char smallLetter = GenerateChar(SmallLetters);
			InsertAtRandomPosition(password, smallLetter);
		}
		// Generate one random digit
		char digit = GenerateChar(Digits);
		InsertAtRandomPosition(password, digit);
		// Generate 3 special characters
		for (int i = 1; i <= 3; i++)
		{
			char specialChar = GenerateChar(SpecialChars);
			InsertAtRandomPosition(password, specialChar);
		}
		// Generate few random characters (between 0 and 7)
		int count = rnd.Next(8);
		for (int i = 1; i <= count; i++)
		{
			char specialChar = GenerateChar(AllChars);
			InsertAtRandomPosition(password, specialChar);
		}
		return password.ToString();
	}
	private static void InsertAtRandomPosition(
	StringBuilder password, char character)
	{
		int randomPosition = rnd.Next(password.Length + 1);
		password.Insert(randomPosition, character);
	}
	private static char GenerateChar(string availableChars)
	{
		int randomIndex = rnd.Next(availableChars.Length);
		char randomChar = availableChars[randomIndex];
		return randomChar;
	}
}
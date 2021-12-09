using System;

namespace DatingProfile
{ 
  class Profile
  {
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    public Profile(string name, int age, string city, string country, string pronouns = "they/them")
    {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = new string[0];
    }

    public string ViewProfile()
    {
      string profile = $"Name: {name},\nAge: {age},\nCity: {city},\nCountry: {country},\nPronouns: {pronouns}";

      profile += "\nHobbies:\n";
      foreach (string hobby in this.hobbies)
      {
        profile += $"- {hobby}\n";
      }
      return profile;
    }

    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }
  }
}

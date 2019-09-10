using System;
using Octokit;

namespace GitHubPullAndDescription
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Greeting();
            Console.WriteLine("What directory would you like to run GHPD? (full path please):");
            var userInput = Console.ReadLine();

            var client = new GitHubClient(new ProductHeaderValue("Recursive-Pull-and-Description"));
            
        }

        static void Greeting()
        {
            Console.WriteLine("Welcome to GitHub Pull and Description Scraper");
            Console.WriteLine("This app uses the GitHub API to pull down the latest code\nand populates a 'descriptions.txt' file.");
        }
    }
}

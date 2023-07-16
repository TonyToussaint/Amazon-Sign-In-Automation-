# Amazon-SignIn-Automation
This is an overview of a simple automation program written in C# that utilizes the Selenium framework to automate the process of signing in to Amazon. This program aims to demonstrate basic web automation techniques and is intended for educational purposes.
# Prerequisites
Before running the automation program, ensure you have the following installed on your system:
 - .NET Core SDK - Version 3.1 or later.
 - Visual Studio or any other C# compatible IDE.
# Setup
1. Clone or download this repository to your local machine.
2. Open the project in your preferred C# IDE.
# Dependencies/Packages
This automation program relies on the following NuGet packages, which should be automatically restored upon opening the project in your IDE:
- Selenium.WebDriver (Version X.X.X): The core WebDriver library.
- Selenium.WebDriver.ChromeDriver (Version X.X.X): ChromeDriver, which allows Selenium to interact with the Chrome browser.
- NUnit: a unit-testing framework for all .NET languages.
- Nunit.ConsoleRunner: Console runner for the NUnit 3 unit-testing framework.
- NUnit3TestAdapter: Adapter for running tests in Visual Studio and DotNet. Works with NUnit 3.x.
- Microsoft.TestPlatform.TestHost: This may not be necesarry, however VS would occasionaly give me problems if this wasn't present.
# Running the Program
To execute the Amazon Sign-In automation, follow these steps:
1. Open the project in your C# IDE.
2. Locate the Amazon_automation.cs file, which contains the main automation logic.
3. Open the Test Explorer (select "Test" in the top menu of VS and then click "Test Explorer, or use the shortcut "Ctrl+E, T") and run the test, or right click anywhere in the code and hit "Run Tests".

Upon execution, the automation program will open the Chrome browser, navigate to the Amazon website, find and click the sign-in button, and proceed to fill out the required information (e.g., name, email, password). After completing the sign-in form, the program will submit the details and attempt to sign-in.
- Note: During the automation process, the program may pause at certain steps to allow for elements to load on the page. These pauses are implemented using Thread.Sleep() to keep the program simple. In a real-world scenario, you would use explicit waits or other synchronization methods for better reliability.
# Disclaimer
This automation program is for educational and demonstrational purposes only. Automating websites without permission is against the terms of service of most websites, including Amazon. Always ensure that you have explicit permission from the website owner before performing any automation.

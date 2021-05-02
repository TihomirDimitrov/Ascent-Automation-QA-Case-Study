using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace FirstTaskForUI 
{
    public class Tests
    {

        [Test]
        public void PopulateCorrectDataInForm()
        {
            IWebDriver driver = new FirefoxDriver ();
            driver.Url = "https://www.demoqa.com/automation-practice-form";

            IWebElement firstNameField = driver.FindElement(By.Id ("firstName"));
            IWebElement lastNameField = driver.FindElement(By.Id ("lastName"));
            IWebElement userEmailField = driver.FindElement(By.Id ("userEmail"));
            IWebElement genderRadioButton = driver.FindElement(By.XPath ("//label[text()='Male']"));
            IWebElement userNumber = driver.FindElement(By.Id("userNumber"));
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            IWebElement sportCheckbox = driver.FindElement(By.XPath("//label[text()='Sports']"));

            firstNameField.SendKeys("Тихомир");
            lastNameField.SendKeys("Димитров");
            userEmailField.SendKeys("ivan@abv.bg");
            genderRadioButton.Click();
            userNumber.SendKeys("0896621863");
            sportCheckbox.Click();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,1000)");

            submitButton.Click();
            driver.FindElement(By.Id("example-modal-sizes-title-lg"));
            driver.Quit();
        }
    }
}
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{
    public class LoginPage
    {
        private By username = By.XPath("//input[@name='user-name']");
        private By password = By.XPath("//input[@name='password']");
        private By loginButton = By.XPath("//input[@name='login-button']");
    public void EnterUsername(string user)
        {
            WebDriverUtilities.FindElement(username).Clear();
            WebDriverUtilities.FindElement(username).SendKeys(user);
        }

        public void EnterPassword(string pass)
        {
            WebDriverUtilities.FindElement(password).Clear();
            WebDriverUtilities.FindElement(password).SendKeys(pass);
        }

        public void ClickLoginButton()
        {
            WebDriverUtilities.FindElement(loginButton).Click();
        }
    }
public void EnterUsername(string user)
        {
            WebDriverUtilities.FindElement(username).Clear();
            WebDriverUtilities.FindElement(username).SendKeys(user);
        }

        public void EnterPassword(string pass)
        {
            WebDriverUtilities.FindElement(password).Clear();
            WebDriverUtilities.FindElement(password).SendKeys(pass);
        }

        public void ClickLoginButton()
        {
            WebDriverUtilities.FindElement(loginButton).Click();
        }
    }

﻿using Framework.Elements;
using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages
{
    public class MainPage: BasePage
    {
        public MainPage( ) : base(nameof(MainPage), By.TagName("video"))
        {
        }

        private Button SignUpButton => new Button("Sign Up", By.XPath("//span[contains(text(), 'Free sign up')]"));

        public void ClickSignUpButton() => SignUpButton.Click();
    }
}
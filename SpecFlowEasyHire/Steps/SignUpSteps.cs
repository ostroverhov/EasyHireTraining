﻿using Framework.Drivers;
using NUnit.Framework;
using SpecFlowEasyHire.Models;
using SpecFlowEasyHire.Pages.Forms;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class SignUpSteps
    {
        private readonly SignUpForm _signUpForm;

        public SignUpSteps(BrowserFactory browserFactory)
        {
            _signUpForm = new SignUpForm(browserFactory.Current);
        }

        [Then("sign up form should be presented")]
        public void ThenSignUpFormShouldBePresented()
        {
            Assert.IsTrue(_signUpForm.IsPagePresent(), "Sign up form should be presented");
        }

        [When("select account (.*)")]
        public void WhenSelectAccount(SignUpForm.AccountTypeItem item)
        {
            _signUpForm.SelectAccountType(item);
        }
        
        [When("type sign up user data")]
        public void WhenTypeSignUpUserData(SignUpUser signUpUser)
        {
            _signUpForm.TypeEmail(signUpUser.Email)
                .TypeFirstName(signUpUser.FirstName)
                .TypeLastName(signUpUser.LastName)
                .TypePassword(signUpUser.Password);
        }
        
        [When("click accept terms and conditions check box")]
        public void WhenClickAcceptTermsAndConditionsCheckBox()
        {
            _signUpForm.ClickTermsAndConditionsCheckBox();
        }
        
        [When("click sign up button from sign up form")]
        public void WhenClickSignUpButtonFromSignUpForm()
        {
            _signUpForm.ClickSignUpButton();
        }
        
        [Then("check sign up alert message")]
        public void ThenCheckSignUpAlertMessage()
        {
            StringAssert.Contains(_signUpForm.GetTextFromSignUpAlert(), "Thank you for signing up! Please check your email to activate your account.", 
                "Sign up alert message is not correct");
        }
        
        [Then("sign up button is not active")]
        public void ThenSignUpButtonIsNotActive()
        {
            Assert.IsFalse(_signUpForm.IsSignUpButtonPresent(), "Sign up button should not be active");
        }
    }
}
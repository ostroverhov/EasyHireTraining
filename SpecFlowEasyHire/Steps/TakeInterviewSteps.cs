﻿using FluentAssertions;
using SpecFlowEasyHire.Pages.Forms;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class TakeInterviewSteps
    {
        private readonly TakeInterviewForm _takeInterviewForm;

        public TakeInterviewSteps()
        {
            _takeInterviewForm = new TakeInterviewForm();
        }

        [Then("take interview form should be presented")]
        public void ThenSignUpFormShouldBePresented()
        {
            _takeInterviewForm.IsPagePresent().Should().BeTrue("Take interview form should be presented");
        }

        [When("select random interview language on take interview form")]
        public void WhenSelectRandomInterviewLanguageOnTakeInterviewForm()
        {
            _takeInterviewForm.ClickSelectLanguageComboBox();
            _takeInterviewForm.ClickComboBoxItem(new Random().Next(_takeInterviewForm.SizeComboBox()));
        }

        [When("select random question category on take interview form")]
        public void WhenSelectRandomQuestionCategoryOnTakeInterviewForm()
        {
            _takeInterviewForm.ClickSelectQuestionCategoryComboBox();
            _takeInterviewForm.ClickComboBoxItem(new Random().Next(_takeInterviewForm.SizeComboBox()));
        }

        [When("type email for take interview (.*)")]
        public void WhenTypeEmailForTakeInterview(string email)
        {
            _takeInterviewForm.TypeEmail(email);
        }

        [When("click accept terms and conditions check box on take interview form")]
        public void WhenClickAcceptTermsAndConditionsCheckBoxOnTakeInterviewForm()
        {
            _takeInterviewForm.ClickTermsAndConditionsCheckBox();
        }

        [When("click continue button on take interview form")]
        public void WhenClickContinueButtonOnTakeInterviewForm()
        {
            _takeInterviewForm.ClickContinueButton();
        }

        [When("click request practice interview on take interview form")]
        public void WhenClickRequestPracticeInterviewOnTakeInterviewForm()
        {
            _takeInterviewForm.ClickRequestPracticeInterview();
        }

        [Then("check take interview alert message")]
        public void ThenCheckTakeInterviewAlertMessage()
        {
            _takeInterviewForm.GetTextFromTakeInterviewAlert().Should().Contain("The Interview invitation is sent. Please, check your e-mail.");
        }
    }
}
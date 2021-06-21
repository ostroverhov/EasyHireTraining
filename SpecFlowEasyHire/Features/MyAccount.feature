@web
Feature: My account page

    Scenario: Check profile information
        Given main page is present
        When click header button LogIn
        Then login form should be presented

        When type login data
          | Name     | Value               |
          | Email    | easyhire6@gmail.com |
          | Password | Test1234@           |
        And click Login button
        Then my account side bar should be presented
        And my account header form should be presented

        When click menu button on my account
        Then side menu on my account is present

        When click button Settings on side menu on my account
        Then user profile on my account is present
        And check profile information on my account
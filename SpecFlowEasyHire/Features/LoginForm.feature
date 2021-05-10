Feature: Login form

    Background:
        Given main page is present
        When click header button LogIn
        Then login form should be presented

    Scenario: Successful login
        When type login data
          | Name     | Value               |
          | Email    | easyhire6@gmail.com |
          | Password | Test1234@           |
        And click Login button
        Then my account side bar should be presented
        And my account header form should be presented

    Scenario Outline: Login without data
        When type login data
          | Name     | Value      |
          | Email    | <Email>    |
          | Password | <Password> |
        Then login button is not active

        Examples:
          | Email               | Password |
          |                     | qwe      |
          | easyhire6@gmail.com |          |

    Scenario: Login with incorrect data
        When type login data
          | Name     | Value              |
          | Email    | easyhire@gmail.com |
          | Password | Test               |
        And click Login button
        Then check account not found alert message
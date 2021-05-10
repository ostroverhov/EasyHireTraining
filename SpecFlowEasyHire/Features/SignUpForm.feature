Feature: SignUpForm

    Background:
        Given main page is present
        When click sign up button from main page
        Then sign up form should be presented

    Scenario Outline: Successful create account
        When select account <AccountType>
        And type sign up user data
          | Name      | Value                 |
          | Email     | easyhirenew@gmail.com |
          | FirstName | Easy                  |
          | LastName  | Hire                  |
          | Password  | Test1234@             |
        And click accept terms and conditions check box
        And click sign up button from sign up form
        Then check sign up alert message

        Examples:
          | AccountType   |
          | HiringManager |
          | Applicant     |

    Scenario Outline: Sign up without data
        When select account HiringManager
        And type sign up user data
          | Name      | Value       |
          | Email     | <Email>     |
          | FirstName | <FirstName> |
          | LastName  | <LastName>  |
          | Password  | <Password>  |
        Then sign up button is not active

        Examples:
          | Email                 | FirstName | LastName | Password  |
          | easyhirenew@gmail.com | Easy      | Hire     |           |
          | easyhirenew@gmail.com | Easy      |          | Test1234@ |
          | easyhirenew@gmail.com |           | Hire     | Test1234@ |
          |                       | Easy      | Hire     | Test1234@ |
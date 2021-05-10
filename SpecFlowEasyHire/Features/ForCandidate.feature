Feature: For candidate page

    Background:
        Given main page is present
        When click header button ForCandidate
        Then for candidate page should be presented
        And header form is present
    
    Scenario: Go to For Candidate page and take practice interview through the form
        When click take practice interview button
        Then take interview form should be presented

        When select random interview language on take interview form
        And select random question category on take interview form
        And type email for take interview easyhire@gmail.com
        And click accept terms and conditions check box on take interview form
        And click continue button on take interview form
        Then check take interview alert message

    Scenario: Go to For Candidate page and take practice interview through the candidate page
        When select random interview language on 'for candidate' page
        And select random question category on 'for candidate' page
        And click take practice interview button on the select panel
        Then take interview form should be presented
        
        When type email for take interview easyhire@gmail.com
        And click accept terms and conditions check box on take interview form
        And click request practice interview on take interview form
        Then check take interview alert message
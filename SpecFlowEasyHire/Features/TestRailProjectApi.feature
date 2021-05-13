Feature: TestRail API (Project)

    Scenario: Add new project
        When uri for add project
        And body for add project created
        And send api request
        Then check status code OK
        And check project body from response

    Scenario: Get all projects
        When uri for get all projects
        And send api request
        Then check status code OK
        
    Scenario: Delete project
        When get id last project
        And uri for delete last project
        And send api request
        Then check status code OK
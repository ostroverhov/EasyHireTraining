@web
Feature: JobBoard page

    Background:
        Given main page is present
        When click header button JobBoard
        And switch to last tab
        Then job board page is present

    Scenario: Go to Job board page and check job description
        When click random job label
        Then job description page is present
        And job title is present
        And job description is present

    Scenario: Validate search job form on the page
        When type search key word Search
        Then check search key word
        
        When select random country
        Then check select by country field
        
        When select random salary range
        Then check salary range field
        
        When select random currency
        Then check currency field
        

Feature: Enroll Policy
As a user
I want to enroll in a policy using the credit card
So that I can have coverage for the apartment

    Scenario Outline: User Enrolls Policy With CC
        Given User is on
        When User puts a '<ZipCode>'
        And User picks an apartment '<Apartment>'
        And User puts personal information '<FirstName>', '<LastName>', '<Email>'
        And User picks unitNumber '<UnitNumber>'
        And User picks package '<Package>'
        And User skips the additional coverages page
        And User passes the insurance screening page
        And User puts '<Birthday>' and '<PhoneNumber>'
        And User picks '<PaymentFrequency>'
        And User fills out CC information on the payment page '<FirstName>'
        Then User is able to click on the Pay Button

        Examples:
          | ZipCode | Apartment      | FirstName | LastName | Email               | PhoneNumber | UnitNumber | Package        | Birthday                  | PaymentFrequency |
          | 77477   | Arc            | Osman     | Gulle    | oigulle@gmail.com   | 8328127331  | 1          | Better Package | Thursday, August 3, 2006  | yearly           |
          | 77406   | Grand Fountain | Alex      | Gulle    | alexgulle@gmail.com | 2132132131  | 1          | Better Package | Wednesday, August 2, 2006 | yearly           |
        
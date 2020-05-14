Feature: Profile
	In order to share skills user creates a profile. 
	User would like to create, read, update and delete detials.
#Eucation Tab
@mytag
Scenario: User creates Education record with valid inputs.
	Given User is in profile page	
	When user adds education details
	Then education details successfully added
@mytag
Scenario: User updates Education details
     Given user clicks on education tab to view details
     When  user edits education details
     Then education details updated successfully
@mytag
Scenario: User deletes education record
      Given  user clicks on education tab to view details
      When user deletes education record
      Then education record deleted successfully

#Language Tab
@ignore
Scenario: User creates Language record with valid inputs.
	Given User is in profile page	
	When user adds Language details
	Then Language details successfully added
@ignore
Scenario: User updates Language details
     Given user clicks on Language tab to view details
     When  user edits Language details
     Then Language details updated successfully
@mytag
Scenario: User deletes Language record
      Given  user clicks on Language tab to view details
      When user deletes Language record
      Then Language record deleted successfully

#Skills Tab
@ignore
Scenario: User creates Skills record with valid inputs.
	Given User is in profile page	
	When user adds Skills details
	Then Skills details successfully added
@ignore
Scenario: User updates Skills details
     Given user clicks on Skills tab to view details
     When  user edits Skills details
     Then Skills details updated successfully
@ignore
Scenario: User deletes Skills record
      Given  user clicks on Skills tab to view details
      When user deletes Skills record
      Then Skills record deleted successfully

#Certifications Tab
@ignore
Scenario: User creates Certifications record with valid inputs.
	Given User is in profile page	
	When user adds Certifications details
	Then Certifications details successfully added
@ignore
Scenario: User updates Certifications details
     Given user clicks on Certifications tab to view details
     When  user edits Certifications details
     Then Certifications details updated successfully
@ignore
Scenario: User deletes Certifications record
      Given  user clicks on Certifications tab to view details
      When user deletes Certifications record
      Then Certifications record deleted successfully

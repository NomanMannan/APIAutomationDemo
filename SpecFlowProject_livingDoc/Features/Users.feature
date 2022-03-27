Feature: GetUsers
	Test GET users operation with Restsharp.net

Scenario: Verify User Name from Users Endpoint 
	Given I perform GET operation for <endpoint>
	When I perform operation for user <user_id>
	Then I should see the <actual_user_name> as <expected_user_name>
	

	Examples: 
	| endpoint			| user_id	| actual_user_name | expected_user_name		|
	| users/{userid}	| 400		| name             | Raj Agarwal			|
	| users/{userid}	| 600		| name             | Inder Khanna			|
	| users/{userid}	| 300		| name             | Fr. Adwitiya Acharya   |
	| users/{userid}	| 500       | name             | Ekaparnika Trivedi III |  


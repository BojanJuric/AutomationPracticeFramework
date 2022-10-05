Feature: LogIn
	In order to logging in
	As I user
	I want to be able to successfully log in site

@mytag
Scenario: User can log in
	Given user enter 'jurke@neobee.net' as Email address term and enter 'password' as Password word
	When user submits the Sign In button
	Then message 'Welcome to your account. Here you can manage all of your personal information and orders.' is presented to the user
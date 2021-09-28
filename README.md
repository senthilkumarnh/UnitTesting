# Unit Testing

## What is unit testing?
Unit testing is a way to make sure your function(smallest unit) works as expected.

## What is not unit testing?
A unit test that communicates with database/file system/API/external system/external methods.

## When do we write unit testing?
We agreed to write unit testing after our class design and before implementation. It will evolve along with the implementation phase.

## What do we need for unit testing?
We need a framework. We discussed Nunit/MsTest/Xunit framework and agreed to use Xunit. Please refer https://xunit.net/ 

## When we want to write multiple test cases with different parameter values, how do we reuse and less code?
Data-driven tests will help us to save parameterized unit test cases and pass parameter values as inline.

## How do we handle external dependency(function belongs to other class)?
A mocking framework will help us to solve this problem. We discussed Moq and FakeItEasy and settled with FakeItEasy.
Please refer https://fakeiteasy.readthedocs.io/en/stable/creating-fakes/ 

## How do we improve the readability of the test case?
We can use a fluent validation framework to improve readability. Please refer https://fluentvalidation.net/ 

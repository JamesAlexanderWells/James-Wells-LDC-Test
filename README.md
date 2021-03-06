# James Wells LDC Coding Test

- Complete SQL for the SQL task found in the folder 'SQL TASK'

- Complete C# code and unit tests for C# task can be found in 'JamesWellsLDCStringExercise'



# Assumptions

I was unable to find any details on how to deal with null / empty input strings and how to deal with strings transformed into empty strings so i made some assumptions:

- If a null or empty string has been inputted into the transformer code, the transformer code will return 'Invalid String'
- In the case where the transformed string ends up being empty (such as trying to transform a string of "______" into ""), the transformer code will return 'Invalid String' because the acceptance criteria state not to return null or empty strings
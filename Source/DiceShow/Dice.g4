// Define a grammar called Dice
// Dice grammar starts with only a single label and dice spec
grammar Dice;
options { language=CSharp_v4_5; }

statement: dice (',' dice)*;
// actually, fudge dice should be rolled as 4f or 2f, the sides are already defined
dice: INT ('d'|'D') INT;
	 
INT: [0-9]+ ;
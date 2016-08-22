//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3.1-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Dice.g4 by ANTLR 4.5.3.1-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3.1-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class DiceParser : Parser {
	public const int
		T__0=1, T__1=2, T__2=3, NUMBER=4;
	public const int
		RULE_statement = 0, RULE_dice = 1;
	public static readonly string[] ruleNames = {
		"statement", "dice"
	};

	private static readonly string[] _LiteralNames = {
		null, "','", "'d'", "'D'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, "NUMBER"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Dice.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public DiceParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class StatementContext : ParserRuleContext {
		public DiceContext[] dice() {
			return GetRuleContexts<DiceContext>();
		}
		public DiceContext dice(int i) {
			return GetRuleContext<DiceContext>(i);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_statement);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 4; dice();
			State = 9;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==T__0) {
				{
				{
				State = 5; Match(T__0);
				State = 6; dice();
				}
				}
				State = 11;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DiceContext : ParserRuleContext {
		public ITerminalNode[] NUMBER() { return GetTokens(DiceParser.NUMBER); }
		public ITerminalNode NUMBER(int i) {
			return GetToken(DiceParser.NUMBER, i);
		}
		public DiceContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dice; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.EnterDice(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDiceListener typedListener = listener as IDiceListener;
			if (typedListener != null) typedListener.ExitDice(this);
		}
	}

	[RuleVersion(0)]
	public DiceContext dice() {
		DiceContext _localctx = new DiceContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_dice);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 12; Match(NUMBER);
			State = 13;
			_la = _input.La(1);
			if ( !(_la==T__1 || _la==T__2) ) {
			_errHandler.RecoverInline(this);
			} else {
				Consume();
			}
			State = 14; Match(NUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x6\x13\x4\x2\t"+
		"\x2\x4\x3\t\x3\x3\x2\x3\x2\x3\x2\a\x2\n\n\x2\f\x2\xE\x2\r\v\x2\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x2\x2\x2\x4\x2\x2\x4\x2\x2\x3\x3\x2\x4\x5\x11\x2"+
		"\x6\x3\x2\x2\x2\x4\xE\x3\x2\x2\x2\x6\v\x5\x4\x3\x2\a\b\a\x3\x2\x2\b\n"+
		"\x5\x4\x3\x2\t\a\x3\x2\x2\x2\n\r\x3\x2\x2\x2\v\t\x3\x2\x2\x2\v\f\x3\x2"+
		"\x2\x2\f\x3\x3\x2\x2\x2\r\v\x3\x2\x2\x2\xE\xF\a\x6\x2\x2\xF\x10\t\x2\x2"+
		"\x2\x10\x11\a\x6\x2\x2\x11\x5\x3\x2\x2\x2\x3\v";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}

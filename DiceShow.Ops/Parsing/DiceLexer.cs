//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.4-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Dice.g4 by ANTLR 4.5.4-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace DiceShow.Ops.Parsing.Internal {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.4-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class DiceLexer : Lexer {
	public const int
		T__0=1, T__1=2, DROP=3, KEEP=4, COUNT=5, REROLL=6, EXPLODE=7, HIT=8, LOWEST=9, 
		HIGHEST=10, ID=11, INT=12, PLUS=13, PLUSPLUS=14, MINUS=15, MINUSMINUS=16, 
		WS=17;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "DROP", "KEEP", "COUNT", "REROLL", "EXPLODE", "HIT", "LOWEST", 
		"HIGHEST", "ID", "INT", "PLUS", "PLUSPLUS", "MINUS", "MINUSMINUS", "WS"
	};

	  
		public const string GrammarVersion = "1.0.0";
		public const string VersionReleaseNotes = @"
			1.0.0 - Support for expression and result keywords
			0.1.2 - removed ; as a SEPARATOR option
			0.1.1 - Moved SEPARATOR
			0.1.0 - Multiple dice in groups with optional labels.
		";


	public DiceLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'d'", "'D'", null, null, null, null, null, null, null, null, null, 
		null, "'+'", "'++'", "'-'", "'--'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "DROP", "KEEP", "COUNT", "REROLL", "EXPLODE", "HIT", 
		"LOWEST", "HIGHEST", "ID", "INT", "PLUS", "PLUSPLUS", "MINUS", "MINUSMINUS", 
		"WS"
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

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x13\xD2\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3"+
		"\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x5\x4"+
		"\x36\n\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5"+
		"\x3\x5\x3\x5\x5\x5\x44\n\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6"+
		"\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x5\x6U\n\x6\x3\a\x3\a"+
		"\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a"+
		"\x3\a\x3\a\x5\ai\n\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b"+
		"\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x5\b\x80\n\b\x3"+
		"\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x3\t\x5\t\x8B\n\t\x3\n\x3\n\x3\n"+
		"\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n\x3\n"+
		"\x3\n\x5\n\x9F\n\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3"+
		"\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x5\v\xB6\n\v\x3\f"+
		"\x6\f\xB9\n\f\r\f\xE\f\xBA\x3\r\x6\r\xBE\n\r\r\r\xE\r\xBF\x3\xE\x3\xE"+
		"\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x12\x6\x12\xCD"+
		"\n\x12\r\x12\xE\x12\xCE\x3\x12\x3\x12\x2\x2\x2\x13\x3\x2\x3\x5\x2\x4\a"+
		"\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2"+
		"\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13\x3\x2\x5"+
		"\x4\x2\x43\\\x63|\x3\x2\x32;\a\x2\v\f\xF\xF\"\"..<=\xE4\x2\x3\x3\x2\x2"+
		"\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2"+
		"\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2"+
		"\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B"+
		"\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2"+
		"#\x3\x2\x2\x2\x3%\x3\x2\x2\x2\x5\'\x3\x2\x2\x2\a\x35\x3\x2\x2\x2\t\x43"+
		"\x3\x2\x2\x2\vT\x3\x2\x2\x2\rh\x3\x2\x2\x2\xF\x7F\x3\x2\x2\x2\x11\x8A"+
		"\x3\x2\x2\x2\x13\x9E\x3\x2\x2\x2\x15\xB5\x3\x2\x2\x2\x17\xB8\x3\x2\x2"+
		"\x2\x19\xBD\x3\x2\x2\x2\x1B\xC1\x3\x2\x2\x2\x1D\xC3\x3\x2\x2\x2\x1F\xC6"+
		"\x3\x2\x2\x2!\xC8\x3\x2\x2\x2#\xCC\x3\x2\x2\x2%&\a\x66\x2\x2&\x4\x3\x2"+
		"\x2\x2\'(\a\x46\x2\x2(\x6\x3\x2\x2\x2)*\a\x66\x2\x2*+\at\x2\x2+,\aq\x2"+
		"\x2,\x36\ar\x2\x2-.\a\x46\x2\x2./\at\x2\x2/\x30\aq\x2\x2\x30\x36\ar\x2"+
		"\x2\x31\x32\a\x46\x2\x2\x32\x33\aT\x2\x2\x33\x34\aQ\x2\x2\x34\x36\aR\x2"+
		"\x2\x35)\x3\x2\x2\x2\x35-\x3\x2\x2\x2\x35\x31\x3\x2\x2\x2\x36\b\x3\x2"+
		"\x2\x2\x37\x38\am\x2\x2\x38\x39\ag\x2\x2\x39:\ag\x2\x2:\x44\ar\x2\x2;"+
		"<\aM\x2\x2<=\ag\x2\x2=>\ag\x2\x2>\x44\ar\x2\x2?@\aM\x2\x2@\x41\aG\x2\x2"+
		"\x41\x42\aG\x2\x2\x42\x44\aR\x2\x2\x43\x37\x3\x2\x2\x2\x43;\x3\x2\x2\x2"+
		"\x43?\x3\x2\x2\x2\x44\n\x3\x2\x2\x2\x45\x46\a\x65\x2\x2\x46G\aq\x2\x2"+
		"GH\aw\x2\x2HI\ap\x2\x2IU\av\x2\x2JK\a\x45\x2\x2KL\aq\x2\x2LM\aw\x2\x2"+
		"MN\ap\x2\x2NU\av\x2\x2OP\a\x45\x2\x2PQ\aQ\x2\x2QR\aW\x2\x2RS\aP\x2\x2"+
		"SU\aV\x2\x2T\x45\x3\x2\x2\x2TJ\x3\x2\x2\x2TO\x3\x2\x2\x2U\f\x3\x2\x2\x2"+
		"VW\at\x2\x2WX\ag\x2\x2XY\at\x2\x2YZ\aq\x2\x2Z[\an\x2\x2[i\an\x2\x2\\]"+
		"\aT\x2\x2]^\ag\x2\x2^_\at\x2\x2_`\aq\x2\x2`\x61\an\x2\x2\x61i\an\x2\x2"+
		"\x62\x63\aT\x2\x2\x63\x64\aG\x2\x2\x64\x65\aT\x2\x2\x65\x66\aQ\x2\x2\x66"+
		"g\aN\x2\x2gi\aN\x2\x2hV\x3\x2\x2\x2h\\\x3\x2\x2\x2h\x62\x3\x2\x2\x2i\xE"+
		"\x3\x2\x2\x2jk\ag\x2\x2kl\az\x2\x2lm\ar\x2\x2mn\an\x2\x2no\aq\x2\x2op"+
		"\a\x66\x2\x2p\x80\ag\x2\x2qr\aG\x2\x2rs\az\x2\x2st\ar\x2\x2tu\an\x2\x2"+
		"uv\aq\x2\x2vw\a\x66\x2\x2w\x80\ag\x2\x2xy\aG\x2\x2yz\aZ\x2\x2z{\aR\x2"+
		"\x2{|\aN\x2\x2|}\aQ\x2\x2}~\a\x46\x2\x2~\x80\aG\x2\x2\x7Fj\x3\x2\x2\x2"+
		"\x7Fq\x3\x2\x2\x2\x7Fx\x3\x2\x2\x2\x80\x10\x3\x2\x2\x2\x81\x82\aj\x2\x2"+
		"\x82\x83\ak\x2\x2\x83\x8B\av\x2\x2\x84\x85\aJ\x2\x2\x85\x86\ak\x2\x2\x86"+
		"\x8B\av\x2\x2\x87\x88\aJ\x2\x2\x88\x89\aK\x2\x2\x89\x8B\aV\x2\x2\x8A\x81"+
		"\x3\x2\x2\x2\x8A\x84\x3\x2\x2\x2\x8A\x87\x3\x2\x2\x2\x8B\x12\x3\x2\x2"+
		"\x2\x8C\x8D\an\x2\x2\x8D\x8E\aq\x2\x2\x8E\x8F\ay\x2\x2\x8F\x90\ag\x2\x2"+
		"\x90\x91\au\x2\x2\x91\x9F\av\x2\x2\x92\x93\aN\x2\x2\x93\x94\aq\x2\x2\x94"+
		"\x95\ay\x2\x2\x95\x96\ag\x2\x2\x96\x97\au\x2\x2\x97\x9F\av\x2\x2\x98\x99"+
		"\aN\x2\x2\x99\x9A\aQ\x2\x2\x9A\x9B\aY\x2\x2\x9B\x9C\aG\x2\x2\x9C\x9D\a"+
		"U\x2\x2\x9D\x9F\aV\x2\x2\x9E\x8C\x3\x2\x2\x2\x9E\x92\x3\x2\x2\x2\x9E\x98"+
		"\x3\x2\x2\x2\x9F\x14\x3\x2\x2\x2\xA0\xA1\aj\x2\x2\xA1\xA2\ak\x2\x2\xA2"+
		"\xA3\ai\x2\x2\xA3\xA4\aj\x2\x2\xA4\xA5\ag\x2\x2\xA5\xA6\au\x2\x2\xA6\xB6"+
		"\av\x2\x2\xA7\xA8\aJ\x2\x2\xA8\xA9\ak\x2\x2\xA9\xAA\ai\x2\x2\xAA\xAB\a"+
		"j\x2\x2\xAB\xAC\ag\x2\x2\xAC\xAD\au\x2\x2\xAD\xB6\av\x2\x2\xAE\xAF\aJ"+
		"\x2\x2\xAF\xB0\aK\x2\x2\xB0\xB1\aI\x2\x2\xB1\xB2\aJ\x2\x2\xB2\xB3\aG\x2"+
		"\x2\xB3\xB4\aU\x2\x2\xB4\xB6\aV\x2\x2\xB5\xA0\x3\x2\x2\x2\xB5\xA7\x3\x2"+
		"\x2\x2\xB5\xAE\x3\x2\x2\x2\xB6\x16\x3\x2\x2\x2\xB7\xB9\t\x2\x2\x2\xB8"+
		"\xB7\x3\x2\x2\x2\xB9\xBA\x3\x2\x2\x2\xBA\xB8\x3\x2\x2\x2\xBA\xBB\x3\x2"+
		"\x2\x2\xBB\x18\x3\x2\x2\x2\xBC\xBE\t\x3\x2\x2\xBD\xBC\x3\x2\x2\x2\xBE"+
		"\xBF\x3\x2\x2\x2\xBF\xBD\x3\x2\x2\x2\xBF\xC0\x3\x2\x2\x2\xC0\x1A\x3\x2"+
		"\x2\x2\xC1\xC2\a-\x2\x2\xC2\x1C\x3\x2\x2\x2\xC3\xC4\a-\x2\x2\xC4\xC5\a"+
		"-\x2\x2\xC5\x1E\x3\x2\x2\x2\xC6\xC7\a/\x2\x2\xC7 \x3\x2\x2\x2\xC8\xC9"+
		"\a/\x2\x2\xC9\xCA\a/\x2\x2\xCA\"\x3\x2\x2\x2\xCB\xCD\t\x4\x2\x2\xCC\xCB"+
		"\x3\x2\x2\x2\xCD\xCE\x3\x2\x2\x2\xCE\xCC\x3\x2\x2\x2\xCE\xCF\x3\x2\x2"+
		"\x2\xCF\xD0\x3\x2\x2\x2\xD0\xD1\b\x12\x2\x2\xD1$\x3\x2\x2\x2\xE\x2\x35"+
		"\x43Th\x7F\x8A\x9E\xB5\xBA\xBF\xCE\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace DiceShow.Ops.Parsing.Internal

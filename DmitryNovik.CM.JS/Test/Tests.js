function assert(caption, expr) {
    return test(caption, function() { ok(expr, expr ? "Passed" : "Failed!"); });
}

function assertTrue(caption, expr) { return assert(caption + " returns True.", expr); }
function assertFalse(caption, expr) { return assert(caption + " returns False.", !expr); }

// Requirement 5:
assertTrue("String.startsWith: correct single-char prefix", "abc".startsWith("a"));
assertTrue("String.startsWith: correct multi-char prefix", "abc".startsWith("ab"));
assertTrue("String.startsWith: self", "abc".startsWith("abc"));
assertTrue("String.startsWith: empty prefix", "abc".startsWith(""));
assertFalse("String.startsWith: empty string", "".startsWith("abc"));
assertFalse("String.startsWith: incorrect case", "abc".startsWith("A"));
assertFalse("String.startsWith: long prefix", "abc".startsWith("Something"));
assertFalse("String.startsWith: incorrect prefix", "abc".startsWith("S"));
assertFalse("String.startsWith: incorrect object type", "A".startsWith({ First: "A" }));

assertTrue("String.endsWith: correct single-char suffix", "abc".endsWith("c"));
assertTrue("String.endsWith: correct multi-char suffix", "abc".endsWith("c"));
assertTrue("String.endsWith: self", "abc".endsWith("abc"));
assertTrue("String.endsWith: empty suffix", "abc".endsWith(""));
assertFalse("String.endsWith: empty string", "".endsWith("abc"));
assertFalse("String.endsWith: incorrect case", "abc".endsWith("C"));
assertFalse("String.endsWith: long suffix", "abc".endsWith("Something"));
assertFalse("String.endsWith: incorrect suffix", "abc".endsWith("S"));
assertFalse("String.endsWith: incorrect object type", "A".endsWith({ First: "A" }));

// Requirement 6:
assert("String.stripHtml: all markup removed", '<p>Have a great <a href="google.com">googling!</a><div/></p>'.stripHtml() === "Have a great googling!");
assert("String.stripHtml: empty returns empty", "".stripHtml() === "");
assert("String.stripHtml: without markup returns intact", "1 &lt; &*%$#@!".stripHtml() === "1 &lt; &*%$#@!");

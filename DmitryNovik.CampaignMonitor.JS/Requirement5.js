function startsWith(s, prefix) {
    if (prefix === null) return (s === null);
    if (s === null) return false;
    // a good case for code reuse:
    return matchSubstring(s, prefix, 0);
}

function endsWith(s, suffix) {
    if (suffix === null) return (s === null);
    if (s === null) return false;
    // a good case for code reuse:
    return matchSubstring(s, suffix, s.length - suffix.length);
}

// add defined above function to String prototype:
String.prototype.startsWith = function(prefix) { return startsWith(this, prefix); }
String.prototype.endsWith = function(suffix) { return endsWith(this, suffix); }

function matchSubstring(s, substr, startPos) {
    if (typeof substr != "string") return false;
    if (substr.length > s.length) return false;

    for (var i = 0; i < substr.length; ++i)
        if (substr.charAt(i) != s.charAt(startPos + i))
            return false;

    return true;
}

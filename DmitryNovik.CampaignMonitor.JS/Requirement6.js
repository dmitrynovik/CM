function stripHtml(markup) {
    if (markup == null) return markup;
    return markup.replace(/<\/?[^>]+(>|$)/g, "");
}

String.prototype.stripHtml = function () { return stripHtml(this); }
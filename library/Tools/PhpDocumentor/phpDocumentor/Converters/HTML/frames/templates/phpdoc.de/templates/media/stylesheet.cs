a { color: #0000C0; text-decoration: underline; }
a:hover { text-decoration: underline; background-color: #FFFFFF }
a:active { text-decoration: underline; background-color: #FFFFFF }

body, table { background-color: #EEEEEE; font-family: Verdana, Arial, sans-serif; font-size: 10pt }
p, li { line-height: 140% }
a img { border: 0px; }
dd { margin-left: 0px; padding-left: 1em; }

/* Page layout/boxes */

.info-box {}
.info-box-title { margin: 1em 0em 0em 0em; padding: .25em; font-weight: normal; font-size: 14pt; border: 2px solid #999999; background-color: #FFFFFF }
.info-box-body { border: 1px solid #999999; padding: .5em; }
.nav-bar { font-size: 8pt; white-space: nowrap; text-align: right; padding: .2em; margin: 0em 0em 1em 0em; }

.oddrow { background-color: #F8F8F8; border: 1px solid #AAAAAA; padding: .5em; margin-bottom: 1em}
.evenrow { border: 1px solid #AAAAAA; padding: .5em; margin-bottom: 1em}

.page-body { max-width: 800px; margin: auto; }
.tree dl { margin: 0px }

/* Index formatting classes */

.index-item-body { margin-top: .5em; margin-bottom: .5em}
.index-item-description { margin-top: .25em }
.index-item-details { font-weight: normal; font-style: italic; font-size: 8pt }
.index-letter-section { background-color: #EEEEEE; border: 1px dotted #999999; padding: .5em; margin-bottom: 1em}
.index-letter-title { font-size: 12pt; font-weight: bold }
.index-letter-menu { text-align: center; margin: 1em }
.index-letter { font-size: 12pt }

/* Docbook classes */

.description {}
.short-description { font-weight: bold; color: #666666; }
.tags {	padding-left: 0em; margin-left: 3em; color: #666666; list-style-type: square; }
.parameters {	padding-left: 0em; margin-left: 3em; font-style: italic; list-style-type: square; }
.redefinitions { font-size: 8pt; padding-left: 0em; margin-left: 2em; }
.package {  }
.package-title { font-weight: bold; font-size: 14pt; border-bottom: 1px solid black }
.package-details { font-size: 85%; }
.sub-package { font-weight: bold; font-size: 120% }
.tutorial { border-width: thin; border-color: #0066ff }
.tutorial-nav-box { width: 100%; border: 1px solid #AAAAAA; background-color: #DDDDFF; }
.nav-button-disabled { color: #AAAAAA; }
.nav-button:active, 
.nav-button:focus, 
.nav-button:hover { background-color: #CCCCCC; outline: 1px solid #999999; text-decoration: none }
.folder-title { font-style: italic }

/* Generic formatting */

.field { font-weight: bold; }
.detail { font-size: 8pt; }
.notes { font-style: italic; font-size: 8pt; }
.separator { background-color: #999999; height: 2px; }
.warning {  color: #FF6600; }
.disabled { font-style: italic; color: #999999; }

/* Code elements */

.line-number {  }

.class-table { width: 100%; }
.class-table-header { border-bottom: 1px dotted #666666; text-align: left; background-color: DDDDFF }
.class-name { color: #000000; font-weight: bold; }

.method-summary { padding-left: 1em; font-size: 8pt }
.method-header { background-color: #DDDDFF; padding: 1px; }
.method-definition { margin-bottom: .3em }
.method-title { font-weight: bold }
.method-name { font-weight: bold; }
.method-signature { font-size: 85%; color: #666666; margin: .5em 0em }
.method-result { font-style: italic; }

.var-summary { padding-left: 1em; font-size: 8pt; }
.var-header { background-color: #DDDDFF; padding: 1px; }
.var-title { margin-bottom: .3em }
.var-type { font-style: italic; }
.var-name { font-weight: bold; }
.var-default {}
.var-description { font-weight: normal; color: #000000; }

.include-title {  }
.include-type { font-style: italic; }
.include-name { font-weight: bold; }

.const-title {  }
.const-name { font-weight: bold; }

/* Syntax highlighting */

.src-code {  border: 1px solid #999999; padding: 1em;
             font-family: 'Courier New', Courier, monospace; font-weight: normal; }
.src-line {  font-family: 'Courier New', Courier, monospace; font-weight: normal; }
.src-comm { color: green; }
.src-id {  }
.src-inc { color: #0000FF; }
.src-key { color: #0000FF; }
.src-num { color: #CC0000; }
.src-str { color: #66cccc; }
.src-sym { font-weight: bold; }
.src-var { }

.src-php { font-weight: bold; }

.src-doc { color: #009999 }
.src-doc-close-template { color: #0000FF }
.src-doc-coretag { color: #0099FF; font-weight: bold }
.src-doc-inlinetag { color: #0099FF }
.src-doc-internal { color: #6699cc }
.src-doc-tag { color: #0080CC }
.src-doc-template { color: #0000FF }
.src-doc-type { font-style: italic }
.src-doc-var { font-style: italic }

.tute-tag { color: #009999 }
.tute-attribute-name { color: #0000FF }
.tute-attribute-value { color: #0099FF }
.tute-entity { font-weight: bold; }
.tute-comment { font-style: italic }
.tute-inline-tag { color: #636311; font-weight: bold }

/* tutorial */

.authors {  }
.author { font-style: italic; font-weight: bold }
.author-blurb { margin: .5em 0em .5em 2em; font-size: 85%; font-weight: normal; font-style: normal }
.example { border: 1px dashed #999999; background-color: #EEEEEE; padding: .5em; }
.listing { border: 1px dashed #999999; background-color: #EEEEEE; padding: .5em; white-space: nowrap; }
.release-info { font-size: 85%; font-style: italic; margin: 1em 0em }
.ref-title-box {  }
.ref-title {  }
.ref-purpose { font-style: italic; color: #666666 }
.ref-synopsis {  }
.title { font-weight: bold; border: 2px solid #999999; background-color: #FFFFFF; padding: 2px }
.cmd-synopsis { margin: 1em 0em }
.cmd-title { font-weight: bold }
.toc { margin-left: 2em; padding-left: 0em }

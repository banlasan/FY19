(function () {
    window.kentico.pageBuilder.registerInlineEditor("ckeditor", {
        init: function (options) {
            var editor = options.editor;
            var divName = "ckeditor-" + editor.dataset.divid;
            var divID = "editor" + editor.dataset.divid;
            if (editor.dataset.divid === null || editor.dataset.divid === undefined) {
                return;
            }
            var getDivID = document.getElementById(divID);
            CKEDITOR.disableAutoInline = true;
            CKEDITOR.dtd.$removeEmpty.span = false;
            CKEDITOR.dtd.$removeEmpty.i = false;
            var ckEditor = CKEDITOR.inline(getDivID, {
                extraPlugins: 'sourcedialog',
                removePlugins: 'sourcearea',
                allowedContent: true,
                extraAllowedContent: 'span;ul;li;table;td;style;*[id];*(*);*{*}',
                toolbar: [
                    ['Sourcedialog', '-'],
                    ['Undo', 'Redo', '-'],
                    ['Bold', 'Italic', 'Underline', 'TextColor', '-'],
                    ['Styles'],
                    ['NumberedList', 'BulletedList', 'Outdent', 'Indent', '-'],
                    ['JustifyLeft', 'JustifyCenter', 'JustifyRight', 'JustifyBlock', '-'],
                    ['InsertLink', 'Unlink', '-'],
                    ['InsertImageOrMedia', 'QuicklyInsertImage', 'Table']
                ]
            });
            ckEditor.on('change', function (evt) {
                var event = new CustomEvent("updateProperty", {
                    detail: {
                        name: options.propertyName,
                        value: ckEditor.getData(),
                        refreshMarkup: false,
                    }
                });
                editor.dispatchEvent(event);
            });
        },
        destroy: function (options) { },
        dragStart: function (options) { }
    });
})();

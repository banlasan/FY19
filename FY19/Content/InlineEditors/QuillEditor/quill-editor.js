

(function () {
    window.kentico.pageBuilder.registerInlineEditor("quill-editor", {
        init: function (options) {
            var editor = options.editor;

            var divname = 'quill-editor-' + editor.dataset.divid;

            console.log('div id - ' + editor.dataset.divid);

            if (editor.dataset.divid === null || editor.dataset.divid === undefined) { return; }

            var getDiv = document.getElementsByClassName(divname)[0];

            console.log('div name - ' + getDiv);

            var toolbarOptions = [
                ['bold', 'italic', 'underline', 'strike'],        // toggled buttons
                ['blockquote', 'code-block'],

                [{ 'header': 1 }, { 'header': 2 }],               // custom button values
                [{ 'list': 'ordered' }, { 'list': 'bullet' }],
                [{ 'script': 'sub' }, { 'script': 'super' }],      // superscript/subscript
                [{ 'indent': '-1' }, { 'indent': '+1' }],          // outdent/indent
                [{ 'direction': 'rtl' }],                         // text direction

                [{ 'size': ['small', false, 'large', 'huge'] }],  // custom dropdown
                [{ 'header': [1, 2, 3, 4, 5, 6, false] }],

                [{ 'color': [] }, { 'background': [] }],          // dropdown with defaults from theme
                [{ 'font': [] }],
                [{ 'align': [] }],

                ['clean'],                                         // remove formatting button

                ['link', 'image']                                 // image
            ];

            var quill = new Quill(getDiv, { modules: { toolbar: toolbarOptions }, theme: 'snow' });

            quill.on('editor-change', function () {
                console.log('editor change')
                var event = new CustomEvent("updateProperty", {
                    detail: {
                        name: options.propertyName,
                        value: nativeEditor.getData(),
                        refreshMarkup: false
                    }
                });

                editor.dispatchEvent(event);
            })
        },

        destroy: function (options) {
            //var mediumEditor = MediumEditor.getEditorFromElement(options.editor);
            //if (mediumEditor) {
            //    mediumEditor.destroy();
            //}
        },

        dragStart: function (options) {
            //var mediumEditor = MediumEditor.getEditorFromElement(options.editor);
            //var focusedElement = mediumEditor && mediumEditor.getFocusedElement();

            //var focusedMediumEditor = focusedElement && MediumEditor.getEditorFromElement(focusedElement);
            //var toolbar = focusedMediumEditor && focusedMediumEditor.getExtensionByName("toolbar");

            //if (focusedElement && toolbar) {
            //    toolbar.hideToolbar();
            //    focusedElement.removeAttribute("data-medium-focused");
            //}
        }
    });
})();

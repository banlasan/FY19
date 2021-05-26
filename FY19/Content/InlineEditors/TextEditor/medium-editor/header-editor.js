(function () {
    window.kentico.pageBuilder.registerInlineEditor("header-editor", {
        init: function (options) {
           // console.log("THIS IS MY OTIONS", options);
            var editor = options.editor;
            var config = {
                toolbar: {
                    buttons: ["bold", "italic", "underline", "orderedlist", "unorderedlist", "h1", "h2", "h3"]
                },
                imageDragging: false,
                extensions: {
                    imageDragging: {}
                },  
                disableDoubleReturn: false
               
            };

            if (editor.dataset.enableFormatting === "False") {
                config.toolbar = false;
                config.keyboardCommands = false;
            }

           // const selectElement = editor;
           // console.log(selectElement);

            var mediumEditor = new MediumEditor(editor, config);

            var data = "";

            //max length of Header
            var max = 199;

            //event for typing 
            editor.addEventListener('keydown', function (e) {
          
                check_charcount(max, e);
            }); 
            //event for typing
            editor.addEventListener('keyup', function (e) {

                check_charcount(max, e);
            }); 
           
            var count = 0;
            function check_charcount(max, e) {   
                count += data.length;
                if (e.which != 8 && data.length > max) {
                    // $('#'+content_id).text($('#'+content_id).text().substring(0, max));
                    e.preventDefault();
                }
               // $('#Id-H2').innerHTML = count;
            }
           
            mediumEditor.subscribe("editableInput", function (e, s) {
                data = e.srcElement.innerText;
                console.log(data.length)
                if (data.length > 199) {
                    alert("Maximum of 200 characters.");
                 //what to do next
                    
                }
                else {
                    var event = new CustomEvent("updateProperty", {
                        detail: {
                            name: options.propertyName,
                            value: e.srcElement.innerHTML,
                            refreshMarkup: false
                        }
                    });
                    editor.dispatchEvent(event);
                   
                }

               
               
                
            });
        },

        destroy: function (options) {
            var mediumEditor = MediumEditor.getEditorFromElement(options.editor);
            if (mediumEditor) {
                mediumEditor.destroy();
            }
        },

        dragStart: function (options) {
            var mediumEditor = MediumEditor.getEditorFromElement(options.editor);
            var focusedElement = mediumEditor && mediumEditor.getFocusedElement();

            var focusedMediumEditor = focusedElement && MediumEditor.getEditorFromElement(focusedElement);
            var toolbar = focusedMediumEditor && focusedMediumEditor.getExtensionByName("toolbar");

            if (focusedElement && toolbar) {
                toolbar.hideToolbar();
                focusedElement.removeAttribute("data-medium-focused");
            }
        }
    });
})();

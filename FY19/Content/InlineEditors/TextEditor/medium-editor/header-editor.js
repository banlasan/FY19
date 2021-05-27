(function () {
    window.kentico.pageBuilder.registerInlineEditor("header-editor", {
        init: function (options) {
            
           
           // console.log("THIS IS MY OTIONS", options);
            var editor = options.editor;
            var countText = editor.innerHTML.replace(/(<([^>]+)>)/gi, "").length;
            var data = editor.innerHTML.replace(/(<([^>]+)>)/gi, "");
            console.log(countText);
            var config = {
                toolbar: {
                    buttons: ["bold", "italic", "underline", "orderedlist", "unorderedlist", "h1", "h2", "h3"]
                },
                imageDragging: false,
                extensions: {
                    imageDragging: {}
                },  
                disableDoubleReturn: false,
                paste: {
                    /* This example includes the default options for paste,
                       if nothing is passed this is what it used */
                    forcePlainText: true,
                    cleanPastedHTML: false,
                    cleanReplacements: [],
                    cleanAttrs: ['class', 'style', 'dir'],
                    cleanTags: ['meta'],
                    unwrapTags: []
                }
               
            };

            if (editor.dataset.enableFormatting === "False") {
                config.toolbar = false;
                config.keyboardCommands = false;
            }

         

           // const selectElement = editor;
           // console.log(selectElement);
            //max length of Header
            var max = 200;

            //event for typing 
            editor.addEventListener('keydown', function (e) {
            
                check_charcount(max, e);
            });
            //event for typing
            editor.addEventListener('keyup', function (e) {
             
                check_charcount(max, e);
            });

            editor.addEventListener('keypress', function (e) {
              
                check_charcount(max, e);
            });


           // var count = 0;
            function check_charcount(max, e) {
               // count += data.length;
                if (e.which != 8 && data.length >= max) {
                    // $('#'+content_id).text($('#'+content_id).text().substring(0, max));
                    e.preventDefault();
                }
             
                // $('#Id-H2').innerHTML = count;
            }
          
            var mediumEditor = new MediumEditor(editor, config);

            //function for caret to display at the last character of the div because the innerHTML will reset the caret in the index of a div
            function setCaretPosition() {
                const editableDiv = editor;
                const lastLine = editableDiv.innerHTML.replace(/.*?(<br>)/g, '');
                const selection = window.getSelection();
                selection.collapse(editableDiv.childNodes[editableDiv.childNodes.length - 1], lastLine.length);
            }
            
       
            mediumEditor.subscribe("editableInput", function (e, s) {
               // data = e.srcElement.innerText.replace(/(\r\n|\n|\r)/gm, "");
                data = e.srcElement.innerHTML.replace(/(<([^>]+)>)/gi, "");
              //  console.log(e);
           
              //  console.log(data);
                if (data.length > 200) {
                
                 //what to do next
                    //remove all characters
                    var split = data.substr(0, 200);
                    editor.innerHTML = split;
                    setCaretPosition();
               
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

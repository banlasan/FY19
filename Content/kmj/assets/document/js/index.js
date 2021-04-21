// JavaScript Document
//$(function() {
//  $('.figure-area__content__btn img').hover(function() {
 
//    $(this).parent().next('.figure-area-content').css('display', 'block');
 // }, function() {
 
 //   $(this).parent().next('.figure-area-content').css('display', 'none');
 // });
//
$(function() {
 $('a[href^="#a"]').click(function(){
    var speed = 800;
    var href= $(this).attr("href");
    var target = $(href == "#" || href == "" ? 'html' : href);
    var position = target.offset().top;
    $("html, body").animate({scrollTop:position}, speed, "swing");
    return false;
  });
});

$(function() {
	//ホバーの挙動
  $('.figure-area__content__btn img').hover(function() {
	 //マウスイン
	  	if ($(this).parent().next('.figure-area-content').css('display') == 'block') {
		} else {
			var img_url =$(this).attr("src").split(".");
			$(this).attr('src',img_url[0]+'_o'+'.png');
		}
	//マウスアウト
 }, function() {
	  	if ($(this).parent().next('.figure-area-content').css('display') == 'block') {
		} else {
			var src = $(this).attr('src').replace('_o', ''); 
		$(this).attr('src', src);
	}	
  });
	
function allclose () { 
        //他のポップアップを消す
		$('.figure-area-content').css('display', 'none');
		
		//他のボタン画像を戻す
		$('.figure-area__content__btn img').each(function(){
			var src = $(this).attr('src').replace('_o', ''); 
			$(this).attr('src', src);
		});
    }
	
	$('.figure-area__content__btn img').on('click', function() {
		var thissrc = $(this).attr('src');
		//クリック済みのボタンが押されたときの処理
		if ($(this).parent().next('.figure-area-content').css('display') == 'none') {
			allclose();
			$(this).parent().next('.figure-area-content').css('display', 'block');
			var img_url =$(this).attr("src").split(".");
			$(this).attr('src',img_url[0]+'_o'+'.png');
		} else {
		
		allclose();
		
		}

	});
	
	//クローズボタンが押された時の処理
	$('.figure-area-content__close').on('click', function() {
		allclose();
	});
	//領域外が押されたら消える
	$(document).on('click touchend', function(event) {
		if (!$(event.target).closest('.figure-area__content').length) {
			allclose();
		}
	});
	
	
});

//$(function() {
//  $('.figure-area-content').hover(function() {
 
//    $(this).css('display', 'block');
//  }, function() {
 
//    $(this).css('display', 'none');
//  });
//});

$(function() {
	$(".localnavigation__btn").click(function () {
	  $(this).next().toggleClass("is-open");
	});
});

$(function() {
	$(".content-inner__select-category >p").click(function () {
	  $(this).next().toggleClass("is-open");
	});
});

//ローカルナビゲーションのホバー対策
//$(function() {
//	$('.localnavigation ul li a').on('mouseenter touchstart', function(){
//         $(this).addClass('hover');
//    }).on('mouseleave touchend', function(){
//         $(this).removeClass('hover');
//    });
//});




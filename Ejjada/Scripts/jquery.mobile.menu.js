// Mobile menu

;(function($){

	
	$.fn.mobileMenu=function(options){
		
		if( !options.triggerMenu) throw new Error("Object options.triggerMenu required!!!");
		if( !options.subMenuTrigger) throw new Error("Object options.triggerMenu required!!!");
		animationSpeed = options.animationSpeed || 500;
		
		
		//Initialization variables
		var $navigationList = this;
				
		if( 'ontouchstart' in window )
		{
			$(options.triggerMenu).on('touchstart',menuToggle);
			$navigationList.find('li '+ options.subMenuTrigger).on('touchstart', subMenuToggle);
		}else
		{
			$(options.triggerMenu).on('click',menuToggle);
			$navigationList.find('li '+ options.subMenuTrigger).on('click', subMenuToggle);
		}
		
		//navigation-toggle 
		
		function menuToggle(e){
			e.preventDefault();
			$navigationList.slideToggle(animationSpeed, setClass);	
			$(this).toggleClass('open-menu');
		};
		
		//navigation list item toggle
		
		function subMenuToggle(e){
			e.preventDefault();
			var subMenu = $(this).toggleClass('plus').parent('li').children('ul');
			
			$(this).parent('li').parent('ul').find('li ul.show').not(subMenu).slideUp(animationSpeed, setClass).siblings('.sub-nav-toggle').toggleClass('plus');
			subMenu.slideToggle(animationSpeed, setClass);	
		}
	
		return this;
	}
	
	// function change style="display:none" to class="hide"
	function setClass (){
		var $this=$(this);
		
		if ($this.attr('style')&&$this.css('display')=='none')
		$this.removeAttr('style').removeClass('show').addClass('hide');
	
		if ($this.attr('style')&&$this.css('display')=='block')
		$this.removeAttr('style').removeClass('hide').addClass('show');
	}
	
}(jQuery))
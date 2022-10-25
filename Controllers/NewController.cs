using Microsoft.AspNetCore.Mvc;

namespace day2ApiInput.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{

    [HttpGet]
    [Route("comparing/{number1}/{number2}")]
    public string GreatOrLessThan(string number1, string number2 )
    {
        long convertNum1 = Convert.ToInt64(number1);
        long convertNum2 =  Convert.ToInt64(number2);
        string answer = "apple";

        if(convertNum1 > convertNum2){
            answer =  $"{convertNum1} > {convertNum2} \n{convertNum2} < {convertNum1}";
        }
        if(convertNum1 < convertNum2){
            answer =  $"{convertNum2} > {convertNum1} \n{convertNum1} < {convertNum2}";
        } else if (convertNum1 == convertNum2){
            answer =  $"{convertNum1} = {convertNum2} \n{convertNum2} = {convertNum1}";
        }

        return answer;

        // return (convertNum1 >  convertNum2)  ? $"{convertNum1} > {convertNum2} /n " : on+wait-cap;
        // return convertNum1 + convertNum2;
    }
    
    //return$"This would be my return {var} "
}
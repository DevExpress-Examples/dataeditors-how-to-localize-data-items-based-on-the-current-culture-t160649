# DataEditors - How to localize data items  based on the current culture


<p>By default, our extensions don't provide any specific method for this scenario. However, it's possible to accomplish this task by creating a special helper method which will take an original text as a parameter, and return a localized text defined in resources. If your data is stored in .xml, create several files for different cultures and dynamically assign them based on the current culture.<br />This example illustrates the both ideas. </p>

<br/>



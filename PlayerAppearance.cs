using UnityEngine;
using System.Collections;

public class PlayerAppearance : MonoBehaviour {
	/* Esta classe pegará do PlayerPrefs todas as informações necessárias à customização do personagem 3D
	 * Ela também é responsável por alterar a aparência do personagem
	 * O personagem conterá um objeto chamado "wardrobe" onde haverá vários arrays de texturas
	 * Cada array trabalhará com uma parte da aparência (e.g.: camisa, calça, cabelo, tênis)
	 * Os índices dos arrays serão salvos no PlayerPrefs
	*/

	private int i_hair;
	private int i_shirt;
	private int i_pants;
	private int i_tennis;

	private void Awake()
	{
		i_hair = PlayerPrefs.GetInt ("i_hair");
		i_hair = PlayerPrefs.GetInt ("i_shirt");
		i_hair = PlayerPrefs.GetInt ("i_pants");
		i_hair = PlayerPrefs.GetInt ("i_tennis");
	}

	private void Wear()
	{
		// Vestir tudo
	}
}
